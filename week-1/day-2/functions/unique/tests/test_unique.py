import unittest
from unique import unique


class Unique(unittest.TestCase):

    def test_unique(self):
        self.assertEqual([1, 11, 34, 52, 61],
                         unique([1, 11, 34, 11, 52, 61, 1, 34]))

if __name__ == '__main__':
    unittest.main()
